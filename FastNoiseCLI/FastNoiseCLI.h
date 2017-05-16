// FastNoiseCLI.h

#pragma once

#include "FastNoise.h"
using namespace System;

namespace FastNoiseCLI {

	public ref class FastNoiseCLI
	{
	private:
		FastNoise* fastNoise;
	public:
		FastNoiseCLI() {
			fastNoise = new FastNoise();
		}
		~FastNoiseCLI() {
			delete fastNoise;
		}	
		
		
		float Get2dValue(int x, int y)
		{
			return fastNoise->GetNoise(x,y);
		}

		int GetSeed() {
			return fastNoise->GetSeed();
		}

		void SetSeed(int seed) {
			fastNoise->SetSeed(seed);
		}

		void SetFrequency(float frequency) {
			fastNoise->SetFrequency(frequency);
		}

		float GetFrequency() {
			return fastNoise->GetFrequency();
		}

		void SetInterp(Interp interp) {
			fastNoise->SetInterp(interp);
		}

		Interp GetInterp() {
			return fastNoise->GetInterp();
		}

		void SetNoiseType(NoiseType noiseType) {
			fastNoise->SetNoiseType(noiseType);
		}

		NoiseType GetNoiseType() {
			return fastNoise->GetNoiseType();
		}
	};
}
