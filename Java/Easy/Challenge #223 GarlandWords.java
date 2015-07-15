//Author /u/jorgegil96 on Reddit
import java.util.Scanner;
import java.io.*;
public class GarlandWords {
	public static void main(String[] args) throws IOException{

		String[] words = {"programmer", "ceramic", "onion", "alfalfa"};
		for(String word : words) System.out.println(word + " -> " + garland(word));
		
		//opt challenge 1
		chain("onion");
		System.out.println("");

		//opt challenge 2
		wordList("enable1.txt");
		wordList("spanish.txt");

	}

	public static int garland(String word){
		for (int i = word.length() - 1; i >= 0; i--) if(word.substring(0, i).equals(word.substring(word.length() - i))) return i;
		return 0;
	}

	public static void chain(String word){
		for(int i = 0; i < 10; i++) System.out.print(word.substring(0, word.length() - garland(word)));
	}

	public static void wordList(String list) throws IOException{
		int max_degree = 0;
		BufferedReader br = new BufferedReader(new FileReader(list));
		String line;
		while((line = br.readLine()) != null) {
			int degree = garland(line);
			if(degree > max_degree)
				max_degree = degree;
		}
		br.close();

		BufferedReader br2 = new BufferedReader(new FileReader(list));
		while((line = br2.readLine()) != null) {
			int degree = garland(line);
			if(degree == max_degree)
				System.out.println(line + " - " + max_degree);
		}
		br2.close();
	}
}