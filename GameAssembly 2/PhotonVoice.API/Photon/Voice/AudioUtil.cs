/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public static class AudioUtil // TypeDefIndex: 4619
	{
		// Nested types
		public class ToneAudioReader<T> : IAudioReader<T> // TypeDefIndex: 4620
		{
			// Fields
			private double k;
			private long timeSamples;
			private Func<double> clockSec;
			private int samplingRate;
			private int channels;
	
			// Properties
			public int Channels { get => default; }
			public int SamplingRate { get => default; }
			public string Error { get; private set; }
	
			// Constructors
			public ToneAudioReader() {} // Dummy constructor
			public ToneAudioReader(Func<double> clockSec = null, double frequency = 440 /* Metadata: 0x0064E55D */, int samplingRate = 441000 /* Metadata: 0x0064E565 */, int channels = 2 /* Metadata: 0x0064E569 */) {}
	
			// Methods
			public void Dispose() {}
			public bool Read(T[] buf) => default;
		}
	
		public class ToneAudioPusher<T> : IAudioPusher<T> // TypeDefIndex: 4622
		{
			// Fields
			private double k;
			private Timer timer;
			private Action<T[]> callback;
			private ObjectFactory<T[], int> bufferFactory;
			private int cntFrame;
			private int posSamples;
			private int bufSizeSamples;
			private int samplingRate;
			private int channels;
	
			// Properties
			public int Channels { get => default; }
			public int SamplingRate { get => default; }
			public string Error { get; private set; }
	
			// Constructors
			public ToneAudioPusher() {} // Dummy constructor
			public ToneAudioPusher(int frequency = 440 /* Metadata: 0x0064E56D */, int bufSizeMs = 100 /* Metadata: 0x0064E571 */, int samplingRate = 441000 /* Metadata: 0x0064E575 */, int channels = 2 /* Metadata: 0x0064E579 */) {}
	
			// Methods
			public void SetCallback(Action<T[]> callback, ObjectFactory<T[], int> bufferFactory) {}
			private void OnTimedEvent(object source, ElapsedEventArgs e) {}
			public void Dispose() {}
		}
	
		public class Resampler<T> : IProcessor<T> // TypeDefIndex: 4623
		{
			// Fields
			protected T[] frameResampled;
			private int channels;
	
			// Constructors
			public Resampler() {} // Dummy constructor
			public Resampler(int dstSize, int channels) {}
	
			// Methods
			public T[] Process(T[] buf) => default;
			public void Dispose() {}
		}
	
		public interface ILevelMeter // TypeDefIndex: 4624
		{
			// Properties
			float CurrentAvgAmp { get; }
			float CurrentPeakAmp { get; }
			float AccumAvgPeakAmp { get; }
	
			// Methods
			void ResetAccumAvgPeakAmp();
		}
	
		public class LevelMeterDummy : ILevelMeter // TypeDefIndex: 4625
		{
			// Properties
			public float CurrentAvgAmp { get => default; } // 0x00000001806A0DC0-0x00000001806A0DD0 
			public float CurrentPeakAmp { get => default; } // 0x00000001806A0DC0-0x00000001806A0DD0 
			public float AccumAvgPeakAmp { get => default; } // 0x00000001806A0DC0-0x00000001806A0DD0 
	
			// Constructors
			public LevelMeterDummy() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void ResetAccumAvgPeakAmp() {} // 0x0000000180246DB0-0x0000000180246DC0
		}
	
		public abstract class LevelMeter<T> : IProcessor<T>, ILevelMeter // TypeDefIndex: 4626
		{
			// Fields
			protected float ampSum;
			protected float ampPeak;
			protected int bufferSize;
			protected float[] prevValues;
			protected int prevValuesHead;
			protected float accumAvgPeakAmpSum;
			protected int accumAvgPeakAmpCount;
			protected float currentPeakAmp;
			protected float norm;
	
			// Properties
			public float CurrentAvgAmp { get; }
			public float CurrentPeakAmp { get; protected set; }
			public float AccumAvgPeakAmp { get; }
	
			// Constructors
			protected LevelMeter() {} // Dummy constructor
			internal LevelMeter(int samplingRate, int numChannels) {}
	
			// Methods
			public void ResetAccumAvgPeakAmp() {}
			public abstract T[] Process(T[] buf);
			public void Dispose() {}
		}
	
		public class LevelMeterFloat : LevelMeter<float> // TypeDefIndex: 4627
		{
			// Constructors
			public LevelMeterFloat() {} // Dummy constructor
			public LevelMeterFloat(int samplingRate, int numChannels) {} // 0x0000000180F1CDD0-0x0000000180F1CE30
	
			// Methods
			public override float[] Process(float[] buf) => default; // 0x0000000180F1CCB0-0x0000000180F1CDD0
		}
	
		public class LevelMeterShort : LevelMeter<short> // TypeDefIndex: 4628
		{
			// Constructors
			public LevelMeterShort() {} // Dummy constructor
			public LevelMeterShort(int samplingRate, int numChannels) {} // 0x0000000180F1CF50-0x0000000180F1CFB0
	
			// Methods
			public override short[] Process(short[] buf) => default; // 0x0000000180F1CE30-0x0000000180F1CF50
		}
	
		public interface IVoiceDetector // TypeDefIndex: 4629
		{
			// Properties
			bool On { get; set; }
			float Threshold { get; set; }
			bool Detected { get; }
			DateTime DetectedTime { get; }
			int ActivityDelayMs { get; set; }
	
			// Events
			event Action OnDetected;
		}
	
		public class VoiceDetectorCalibration<T> : IProcessor<T> // TypeDefIndex: 4630
		{
			// Fields
			private IVoiceDetector voiceDetector;
			private ILevelMeter levelMeter;
			private int valuesPerSec;
			protected int calibrateCount;
			private Action<float> onCalibrated;
	
			// Properties
			public bool IsCalibrating { get => default; }
	
			// Constructors
			public VoiceDetectorCalibration() {} // Dummy constructor
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels) {}
	
			// Methods
			public void Calibrate(int durationMs, Action<float> onCalibrated = null) {}
			public T[] Process(T[] buf) => default;
			public void Dispose() {}
		}
	
		public class VoiceDetectorDummy : IVoiceDetector // TypeDefIndex: 4631
		{
			// Properties
			public bool On { get => default; set {} } // 0x0000000180250A70-0x0000000180250A80 0x0000000180246DB0-0x0000000180246DC0
			public float Threshold { get => default; set {} } // 0x00000001806A0DC0-0x00000001806A0DD0 0x0000000180246DB0-0x0000000180246DC0
			public bool Detected { get => default; } // 0x0000000180250A70-0x0000000180250A80 
			public int ActivityDelayMs { get => default; set {} } // 0x0000000180246C90-0x0000000180246CA0 0x0000000180246DB0-0x0000000180246DC0
			public DateTime DetectedTime { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x00000001802D5F50-0x00000001802D5F60
	
			// Events
			public event Action OnDetected;
	
			// Constructors
			public VoiceDetectorDummy() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		public abstract class VoiceDetector<T> : IProcessor<T>, IVoiceDetector // TypeDefIndex: 4632
		{
			// Fields
			protected float norm;
			protected float threshold;
			private bool detected;
			protected int activityDelay;
			protected int autoSilenceCounter;
			protected int valuesCountPerSec;
			protected int activityDelayValuesCount;
	
			// Properties
			public bool On { get; set; }
			public float Threshold { get; set; }
			public bool Detected { get; protected set; }
			public DateTime DetectedTime { get; private set; }
			public int ActivityDelayMs { get; set; }
	
			// Events
			public event Action OnDetected;
	
			// Constructors
			protected VoiceDetector() {} // Dummy constructor
			internal VoiceDetector(int samplingRate, int numChannels) {}
	
			// Methods
			public abstract T[] Process(T[] buf);
			public void Dispose() {}
		}
	
		public class VoiceDetectorFloat : VoiceDetector<float> // TypeDefIndex: 4633
		{
			// Constructors
			public VoiceDetectorFloat() {} // Dummy constructor
			public VoiceDetectorFloat(int samplingRate, int numChannels) {} // 0x0000000180F36400-0x0000000180F36460
	
			// Methods
			public override float[] Process(float[] buffer) => default; // 0x0000000180F36320-0x0000000180F36400
		}
	
		public class VoiceDetectorShort : VoiceDetector<short> // TypeDefIndex: 4634
		{
			// Constructors
			public VoiceDetectorShort() {} // Dummy constructor
			public VoiceDetectorShort(int samplingRate, int numChannels) {} // 0x0000000180F36550-0x0000000180F365B0
	
			// Methods
			public override short[] Process(short[] buffer) => default; // 0x0000000180F36460-0x0000000180F36550
		}
	
		public class VoiceLevelDetectCalibrate<T> : IProcessor<T> // TypeDefIndex: 4635
		{
			// Fields
			private VoiceDetectorCalibration<T> calibration;
	
			// Properties
			public ILevelMeter LevelMeter { get; private set; }
			public IVoiceDetector VoiceDetector { get; private set; }
			public bool IsCalibrating { get => default; }
	
			// Constructors
			public VoiceLevelDetectCalibrate() {} // Dummy constructor
			public VoiceLevelDetectCalibrate(int samplingRate, int channels) {}
	
			// Methods
			public void Calibrate(int durationMs, Action<float> onCalibrated = null) {}
			public T[] Process(T[] buf) => default;
			public void Dispose() {}
		}
	
		// Methods
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels) {}
		public static void Resample<T>(T[] src, int srcOffset, int srcCount, T[] dst, int dstOffset, int dstCount, int channels) {}
		public static void Resample<T>(T[] src, int srcOffset, int srcCount, int srcChannels, T[] dst, int dstOffset, int dstCount, int dstChannels) {}
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels) {} // 0x0000000180F1B7B0-0x0000000180F1BA60
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels) {} // 0x0000000180F1B510-0x0000000180F1B7B0
		public static void Convert(float[] src, short[] dst, int dstCount) {} // 0x0000000180F1B490-0x0000000180F1B510
		public static void Convert(short[] src, float[] dst, int dstCount) {} // 0x0000000180F1B410-0x0000000180F1B490
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels) {}
		internal static string tostr<T>(T[] x, int lim = 10 /* Metadata: 0x0064E559 */) => default;
	}
}
