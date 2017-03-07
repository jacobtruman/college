

class matWavelet{

	private void split(double[] vec, int N){
		int start = 1;
		int end = N - 1;

		while (start < end){
			for (int i = start; i < end; i = i + 2){
				double tmp = vec[i];
				vec[i] = vec[i+1];
				vec[i+1] = tmp;
			}
			start = start + 1;
			end = end - 1;
		}
	}

	private void merge(double[] vec, int N){
		int half = N >> 1;
		int start = half-1;
		int end = half;

		while (start > 0){
			for (int i = start; i < end; i = i + 2){
				double tmp = vec[i];
				vec[i] = vec[i+1];
				vec[i+1] = tmp;
			}
			start = start - 1;
			end = end + 1;
		}
	}

	public void transStep(double m[][], double v[]){
		int N = m.length;
		double scale, wave;

		linearOps ops = new linearOps();

		for (int i = 0; i < N; i = i + 2){
			scale = ops.dotprod(m[i], v);
			wave = ops.dotprod(m[i+1], v);
			v[i] = scale;
			v[i+1] = wave;
		}

		split(v, N);
	}

	public void invTransStep(double m[][], double v[]){
		int N = m.length;
		double v1, v2;
		linearOps ops = new linearOps();    

		merge(v, N);
		for (int i = 0; i < N; i = i + 2){
			v1 = ops.dotprod(m[i], v);
			v2 = ops.dotprod(m[i+1], v);
			v[i] = v1;
			v[i+1] = v2;
		}
	}
}
