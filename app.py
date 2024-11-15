from flask import Flask, request, jsonify
import yt_dlp
import os
from yt_dlp.utils import download_range_func

app = Flask(__name__)

@app.route('/')
def index():
    return 'Hello from Flask!'

@app.route('/info', methods=['POST'])
def get_video_info():
    data = request.json
    url = data.get('url')
    ydl_opts = {
        'format': 'bestaudio/best',
        'noplaylist': True,
        'quiet': False
    }

    try:
        with yt_dlp.YoutubeDL(ydl_opts) as ydl:
            info_dict = ydl.extract_info(url, download=False)
            formats = info_dict.get('formats', [])
            formats = [f for f in formats if f['ext'] == 'mp4' and f.get('resolution') != 'audio only' and f.get('format_note') is not None]
            return jsonify({'formats': formats}), 200
    except Exception as e:
        return jsonify({'message': 'Invalid URL!'}), 400



@app.route('/download', methods=['POST'])
def download_video():
    print('Request')
    data = request.json
    format_id = data.get('format_id')
    url = data.get('url')
    output_path = data.get('output', '.')
    start_time = data.get('start', '0')
    end_time = data.get('end', '0')
    filename = data.get('filename', '')
    

    print(data)

    ydl_opts = {
        'format': f'{format_id}+bestaudio',  # tải video và âm thanh riêng nếu cần và ghép lại
        'noplaylist': True,
        'quiet': False,
        'force_keyframes_at_cuts': True,
        'outtmpl': os.path.join(output_path, filename if filename else '%(title)s.%(ext)s')
    }

    if start_time != '0' and end_time != '0':
        ydl_opts['download_ranges'] = download_range_func(None, [(start_time, end_time)])

    try:
        with yt_dlp.YoutubeDL(ydl_opts) as ydl:
            ydl.download([url])  # Tải video
        return jsonify({'status': 'success', 'message': 'Video downloaded successfully!'}), 200
    except Exception as e:
        return jsonify({'status': 'error', 'message': str(e)}), 500

if __name__ == '__main__':
    app.run(debug=True, port=5000)  # Chạy server Flask
