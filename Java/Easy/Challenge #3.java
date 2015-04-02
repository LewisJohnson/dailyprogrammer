// Reddit user/Author: foriamraindog
public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.println("Please enter a string to encode: ");
		String s = input.nextLine();

		System.out.println("Enter the number of steps to encode the string by: ");
		int i = input.nextInt();

		String encodedString = caeserCipher(s, i);

		System.out.println("The new encoded String is: " + encodedString);

		String decodedString = caeserDecode(encodedString, i);

		System.out.println("And decoded back again it is: " + decodedString);
		
		input.close();
	} // end method main

	private static String caeserCipher(String s, int i) {
    StringBuffer out = new StringBuffer(s.length());     
    char ca[] = s.toCharArray();
    for (char c : ca) {
        c += i;
        out.append(c);
    } // end for loop
    return out.toString();  
} // end method caeserCipher

	private static String caeserDecode(String s, int i) {
    StringBuffer out = new StringBuffer(s.length());     
    char ca[] = s.toCharArray();
    for (char c : ca) {
        c -= i;
        out.append(c);
    } // end for loop
    return out.toString();  
  } // end method caeserDecode
