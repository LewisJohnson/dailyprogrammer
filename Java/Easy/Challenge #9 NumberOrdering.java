public static void main (String[] args) {
	Scanner input = new Scanner(System.in);
	System.out.print("Enter How Many Inputs: ");
	int num1 = Integer.parseInt(input.readLine());
	int arr[] = new int[num
 
	for (int i = 0; i < num1; i++) {
	    System.out.print("Enter Value: " + (i + 1) + ":");
	    arr[i] = Integer.parseInt(input.readLine());
	} 
	 
	System.out.print("Numbers in Numerical Order:" );
	 
	for(int i = arr.length-1; i >= 0; i--) {
	    Arrays.sort(arr);
	    System.out.print( " " +arr[i]);
	}
} 