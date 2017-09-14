public class Calculator {
	private static int result; // 静态变量，用于存储运行结果

	public void add(int n) {
		result = result + n;
	}

	public void substract(int n) {
		result = result - 1; // 故意的Bug，应该是 result =result-n
	}

	public void multiply(int n) {
	} // 假设此方法在项目完成过程中尚未写好

	public void divide(int n) {
		result = result / n;
	}

	public void square(int n) {
		result = n * n;
	}

	public void squareRoot(int n) { // 求平方根
		for (;;)
			; // Bug : 死循环
	}

	public void clear() { // 将结果清零
		result = 0;
	}

	public int getResult() {
		return result;
	}
}