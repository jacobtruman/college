

public class linearPr{

	private double round4(double d){
		final double multiplier = 10000.0;
		double rounded;

		rounded = Math.round(d * multiplier)/multiplier;
	return rounded;
	}

	public void pr_ordered(double[] vec){
		if (vec != null){
			int len = vec.length;

			if (len > 0){
				System.out.println(round4(vec[0]));

				int num_in_freq = 1;
				int cnt = 0;
				for (int i = 1; i < len; i++){
					System.out.print(round4(vec[i]) + " ");
					cnt++;
					if (cnt == num_in_freq){
						System.out.println();
						cnt = 0;
						num_in_freq = num_in_freq * 2;
					}
				}
			}
		}
	}

	public void prVec( double v[] ){
		for (int i = 0; i < v.length; i++){
			System.out.print( round4(v[i]) + " " );
		}
		System.out.println();
	}

	public void prMat(double m[][]){
		if (m != null){
			int M = m.length;
			int N = m[0].length;

			for (int i = 0; i < M; i++){
				for (int j = 0; j < N; j++){
					System.out.print( round4(m[i][j]) + " " );
				}
				System.out.println();
			}
		}
	}
}
