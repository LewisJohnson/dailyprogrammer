// Created by /u/jorgegil96 on Reddit
// Challenge #213 [Easy] Cellular Automata: Rule 90
// https://www.reddit.com/r/dailyprogrammer/comments/3jz8tt/20150907_challenge_213_easy_cellular_automata/

public class CARule90 {
	public static void states(String input, StringBuilder sb) {
		int before, after;
		for (int i = 0; i < input.length(); i++) {
			before = 0;
			after = 0;
			if (i == 0) {
				after = Character.getNumericValue(input.charAt(i + 1));
			}
			else if (i == input.length() - 1) {
				before = Character.getNumericValue(input.charAt(i - 1));
			}
			else {
				before = Character.getNumericValue(input.charAt(i - 1));
				after = Character.getNumericValue(input.charAt(i + 1));
			}
			if ((before + after) % 2 == 0) {
				System.out.print(" ");
				sb.setCharAt(i, '0');
			}
			else{
				System.out.print("X");
				sb.setCharAt(i, '1');
			}
		}
	}

	public static void main(String[] args) {
		String input = "00000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000";
		StringBuilder sb = new StringBuilder(input);

		int n = 25;

		for (int i = 0; i < input.length(); i++)
			if (input.charAt(i) == '0')
				System.out.print(' ');
			else
				System.out.print('X');

		System.out.println("");

		for (int i = 0; i < n; i++){
			states(sb.toString(), sb);
			if (!sb.toString().contains("1")){
				break;
			}
			System.out.println("");
		}

	}
}