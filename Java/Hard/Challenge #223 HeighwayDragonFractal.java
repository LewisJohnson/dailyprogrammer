//Author /u/jorgegil96 on Reddit.com
import java.util.*;
import java.awt.*;
public class HeighwayDragonFractal {
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();

		String trace;
		trace = getTrace(n); //returns a string of L's and R's that correspond to the left or right turns the trace must take starting from (1, 0)
		//n = 1 -> L
		//n = 2 -> LLR
		//n = 3 -> LLRLLRR 

		ArrayList<Point> coordinates = new ArrayList<Point>();
		coordinates.add(new Point(0, 0));
		coordinates.add(new Point(1, 0));

		for(int i = 0; i < trace.length(); i++){
			int size = coordinates.size();
			compare(coordinates.get(size - 2), coordinates.get(size - 1), trace.charAt(i), coordinates);
		}

		int x = 0;
		int y = 0;

		for(Point p : coordinates) {
			System.out.println("(" + p.getX() + ", " + p.getY() + ")"); //print all points in coordinates
			x += (int) p.getX(); //add all X's
			y += (int) p.getY(); //add all Y's
		}

		System.out.println("Sum, " + x + " and " + y); //print sum of X and Y
	}

	public static String getTrace(int n){
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("");
		String trace = "";

		//starting from "" as the 0 iteration, the "formula" to get the following iteration of turns is:
		//1. take the previous iteration
		//2. add an 'L' at the end
		//3. take the previous iteration again but flip it retrograde, swapping each letter and adding the result after the R
		// example: the 2nd iteration is "L L R"
		//for the next iteration we add L -> "L L R L"
		//We take the original "L L R" and flip it retrograde -> "R L L" and then swap each letter -> "L R R" and add it the end "LLRLLRR"

		for(int i = 0; i < n; i++) {
			stringBuilder.append("L");
			trace = stringBuilder.toString();
			for(int j = trace.length() - 2; j >= 0; j--){
				if(trace.charAt(j) == ('R'))
					stringBuilder.append("L");
				else
					stringBuilder.append("R");
			}
			trace = stringBuilder.toString();
		}

		return trace;
	}

	public static void compare(Point old_point, Point new_point, char c, ArrayList<Point> coordinates){
		//when we know the complete iteration off turns i.e. "LLRLLRR" we compare the last 2 coordinates (starting with (0, 0) and (1, 0)).
		//Depending on the result of this comparison and if the turn is 'L' or 'R' we can deduce the next coordinate..

		int new_x = (int) new_point.getX();
		int new_y = (int) new_point.getY();

		int x = (int) (new_point.getX() - old_point.getX());
		int y = (int) (new_point.getY() - old_point.getY());


		if(x == 1){ //if the difference between coordinates is +1 in X
			if(c == 'L')
				coordinates.add(new Point(new_x, new_y + 1));
			else
				coordinates.add(new Point(new_x, new_y - 1));
		}
		else if(x == -1){ //if the difference between coordinates is -1 in X
			if(c == 'L')
				coordinates.add(new Point(new_x, new_y - 1));
			else
				coordinates.add(new Point(new_x, new_y + 1));
		}
		else if(y == 1){ //if the difference between coordinates is +1 in Y
			if(c == 'L')
				coordinates.add(new Point(new_x - 1, new_y));
			else
				coordinates.add(new Point(new_x + 1, new_y));
		}
		else if(y == -1){//if the difference between coordinates is -1 in Y
			if(c == 'L')
				coordinates.add(new Point(new_x + 1, new_y));
			else
				coordinates.add(new Point(new_x - 1, new_y));
		}

	}
}