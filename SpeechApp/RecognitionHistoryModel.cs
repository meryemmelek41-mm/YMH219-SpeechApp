using System;

namespace SpeechApp
{
    /// <summary>
    /// Mikrofondan tanınan her bir konuşma kaydını temsil eden model sınıfı.
    /// Nesne tabanlı tasarım ile zaman damgası, tanınan metin ve güven skorunu kapsüller.
    /// </summary>
    public class RecognitionHistoryModel
    {
        public DateTime Timestamp { get; }
        public string RecognizedText { get; }
        public float Confidence { get; } // 0.0 - 1.0 aralığı

        public RecognitionHistoryModel(string text, float confidence)
        {
            Timestamp = DateTime.Now;
            RecognizedText = text.Trim();
            Confidence = confidence;
        }

        public int ConfidencePercent => (int)Math.Round(Confidence * 100);

        public override string ToString()
        {
            return $"[{Timestamp:HH:mm:ss}] \"{RecognizedText}\" (Güven Skoru: %{ConfidencePercent})";
        }

        public string ToExportLine()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss}\t%{ConfidencePercent}\t{RecognizedText}";
        }
    }
}
