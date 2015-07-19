//Author /u/jorgegil96 on Reddit.com
import java.util.*;
import java.io.*;
public class EelOfFortune {

	public static boolean problem(String word, String offense) {
		StringBuilder sb = new StringBuilder();
		for(int i = 0; i < word.length(); i++) {
			String c = Character.toString(word.charAt(i));
			if(offense.indexOf(c) != -1) {
				sb.append(c);
			}
		}
		if(sb.toString().equals(offense)) return true;
		else return false;
	}

	public static void main(String[] args) throws IOException{
		ArrayList<String> list = new ArrayList<String>();
		list.add("synchronized");
		list.add("misfunctioned");
		list.add("mispronounced");
		list.add("shotgunned");
		list.add("snond");

		for(String s : list) System.out.println("problem(\"" + s + "\", \"snond\") -> " + problem(s, "snond"));

		//optional challenge #1 Problem count
		int count = 0;
		BufferedReader br = new BufferedReader(new FileReader("enable1.txt"));
		String line;
		while((line = br.readLine()) != null) {
			if(problem(line, "rrizi"))
				count++;
		}
		System.out.println("Problem count => " + count);
	}
}