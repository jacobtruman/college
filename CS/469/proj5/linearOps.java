

import java.lang.Math.*;

public class linearOps{
	public double[] vecCopy(double[] v){
		int N = v.length;
		double rslt[] = new double[N];

		for (int i = 0; i < N; i++){
			rslt[i] = v[i];
		}
	return rslt;
	}

	public double dotprod(double vecA[], double vecB[]){
		int len = Math.min(vecA.length, vecB.length);
		double innerProd = 0.0;

		for (int i = 0; i < len; i++){
			innerProd = innerProd + vecA[i] * vecB[i];
		}
	return innerProd;
	}

	public double vecmag(double v[]){
		return dotprod(v, v);
	}

	public double[] vecadd(double a[], double b[]){
		int len = Math.min(a.length, b.length);
		double rslt[] = new double[len];

		for (int i = 0; i < len; i++){
			rslt[i] = a[i] + b[i];
		}
	return rslt;
	}

	public void vecadd(double c[], double a[], double b[]){
		int len = Math.min(a.length, b.length );

		for (int i = 0; i < len; i++){
			c[i] = a[i] + b[i];
		}
	}

	public double[] vecsub(double a[], double b[]){
		int len = Math.min(a.length, b.length );
		double rslt[] = new double[len];

		for (int i = 0; i < len; i++){
			rslt[i] = a[i] - b[i];
		}

	return rslt;
	}

	public void vecsub(double c[], double a[], double b[]){
		int len = Math.min(a.length, b.length);

		for (int i = 0; i < len; i++){
			c[i] = a[i] - b[i];
		}

	}

	public double[] multScaleVec(double v[], double scale){
		int len = v.length;
		double rslt[] = new double[len];
    
		for (int i = 0; i < len; i++){
			rslt[i] = v[i] * scale;
		}
	return rslt;
	}

	public double[][] matmult(double matA[][], double matB[][]){
		int lenA_d1 = matA.length;
		int lenA_d2 = matA[0].length;

		int lenB_d1 = matB.length;
		int lenB_d2 = matB[0].length;

		double rslt[][] = null;

		if (lenA_d1 != lenB_d2 || lenA_d2 != lenB_d1){
			System.out.println("matrix A must be MxN and matrix B must be NxM");
			System.out.println("matrix A is " + lenA_d1 +" x " + lenA_d2);
			System.out.println("matrix B is " + lenB_d1 +" x " + lenB_d2);
		}else{
			int M = lenA_d1;
			int N = lenA_d2;

			rslt = new double[M][M];

			for (int i = 0; i < M; i++){
				for (int j = 0; j < M; j++){
					double dotProd = 0.0;
					for (int k = 0; k < N; k++){
						dotProd = dotProd + matA[i][k] * matB[k][j];
					}
					rslt[i][j] = dotProd;
				}
			}
		}

		return rslt;
	}

public void matmult(double matC[][], double matA[][], double matB[][]){
	int lenA_d1 = matA.length;
	int lenA_d2 = matA[0].length;

	int lenB_d1 = matB.length;
	int lenB_d2 = matB[0].length;

	int lenC_d1 = matC.length;
	int lenC_d2 = matC[0].length;

	if (lenA_d1 != lenB_d2 || lenA_d2 != lenB_d1) {
		System.out.println("matrix A must be MxN and matrix B must be NxM");
		System.out.println("matrix A is " + lenA_d1 +" x " + lenA_d2 );
		System.out.println("matrix B is " + lenB_d1 +" x " + lenB_d2 );
	}else if (lenA_d1 != lenC_d1 || lenA_d1 != lenC_d2){
		System.out.println("matrix C should be " + lenA_d1 + " x " + lenA_d1 );
		System.out.println("matrix C is " + lenC_d1 +" x " + lenC_d2 );
	}else{
		int M = lenA_d1;
		int N = lenA_d2;

		for (int i = 0; i < M; i++){
			for (int j = 0; j < M; j++){
				double dotProd = 0.0;
				for (int k = 0; k < N; k++){
					dotProd = dotProd + matA[i][k] * matB[k][j];
				}
				matC[i][j] = dotProd;
			}
		}
	}
}

double[][] transpose(double m[][]){
	int M = m.length;
	int N = m[0].length;

	double t[][] = new double[N][M];

	for (int i = 0; i < M; i++){
		for (int j = 0; j < N; j++){
			t[j][i] = m[i][j];
		}
	}

return t;
}

boolean vecCompare(double a[], double b[]){
	boolean rslt = true;
	int N = a.length;

	if (b.length != N){
		rslt = false;
	}else{
		for (int i = 0; i < N; i++){
			if (a[i] != b[i]){
				rslt = false;
				break;
			}
		}
	}
return rslt;
}

boolean matCompare(double a[][], double b[][]){
	boolean rslt = true;
	int M = a.length;
	int N = a[0].length;

	if (M != b.length || N != a[0].length){
		rslt = false;
	}else{
		for (int i = 0; i < M; i++){
			if (!vecCompare(a[i], b[i])){
				rslt = false;
				break;
			}
		}
	}
return rslt;
}

}
