using VideoFlix.PlataformaA;
using VideoFlix.PlataformaB;
using System.Globalization;

using VideoA = VideoFlix.PlataformaA.Video;
using VideoB = VideoFlix.PlataformaB.Video;

VideoA video1 = new("Netflix", 29.90);
VideoB video2 = new("HBO", 32.90);

video1.ExibirA();
video2.ExibirB();
