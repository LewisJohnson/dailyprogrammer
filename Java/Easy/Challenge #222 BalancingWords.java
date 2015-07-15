public class BalancingWords {
	public static void main(String[] args) {
		String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		String word = "STEAD";
		boolean flag = false;

		for(int i = 1; i < word.length() - 1; i++) {
			int left = 0, right = 0;

			for(int j = 0; j < word.length(); j++){
				if(j < i)
					left += (alphabet.indexOf(word.charAt(j) + 1) * (i - j));
				if(j > i)
					right += (alphabet.indexOf(word.charAt(j) + 1) * (j - i));
			}

			if(left == right){
				for(int k = 0; k < word.length(); k++){
					if(k == i)
						System.out.print(" " + word.charAt(k) + " ");
					else
						System.out.print(word.charAt(k));
				}
				System.out.print(" - " + left);
				flag = true;
				return;
			}
		}
		if(!flag)
			System.out.println(word + " DOES NOT BALANCE");
	}
}