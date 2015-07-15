//Author /u/jorgegil96 on Reddit
import java.util.*;
import java.awt.*;

public class GoTime {
	static String my_color, opp_color;
	static Scanner sc;
	static ArrayList<Point> valid_pieces = new ArrayList<Point>();
	static ArrayList<Point> valid_blanks = new ArrayList<Point>();
	static ArrayList<Point> neighbors = new ArrayList<Point>();
	static ArrayList<Point> blanks = new ArrayList<Point>();
	static ArrayList<Point> new_blanks = new ArrayList<Point>();
	static int cont = 0, width, height, max_i, max_j, initialSize; 

	public static void main(String[] args) {
		int group_size;
		ArrayList<Point> blanks = new ArrayList<Point>();
		sc = new Scanner(System.in);

		width = sc.nextInt();
		height = sc.nextInt();
		max_i = height - 1;
		max_j = width - 1;

		sc.nextLine();
		my_color = sc.nextLine();
		if (my_color.equals("b"))
			opp_color = "w";
		else 
			opp_color = "b";

		char board[][] = new char[height][width];
		drawBoard(board, width, height);
		getBlanks(board, width, height, blanks);

		ArrayList<Integer> sizes = new ArrayList<Integer>();
		ArrayList<Point> all_points = new ArrayList<Point>();

		int cont = 0;

		for(Point object : blanks) {
			int i = (int) object.getX();
			int j = (int) object.getY();

			if(cont != 0) {
				board[i][j] = my_color.charAt(0);
			}
			getBlanks(board, width, height, new_blanks);
			findNeighbors(board, new_blanks);
			new_blanks.clear();
			validateNeighbors(board, neighbors);
			findAllPieces(board, valid_pieces);

			sizes.add(valid_pieces.size());
			all_points.add(new Point(i, j));

			valid_pieces.clear();

			board[i][j] = ' ';

			for(int di = 0; di < height; di++)
				for(int dj = 0; dj < width; dj++)
					if(board[di][dj] == '1')
						board[di][dj] = opp_color.charAt(0);


			cont++;
		}

		int min_size = Integer.MAX_VALUE;
		int index = -1;

		for(int i = 0; i < sizes.size(); i++){
			int num = sizes.get(i);
			if(num < min_size){
				min_size = num;
				index = i;
			}
		}


		System.out.println("Min => " + min_size);
		Point best_point = all_points.get(index);
		if(min_size != sizes.get(0))
			System.out.println("Point => " + best_point.getY() + ", " + best_point.getX());	
		else
			System.out.println("No constructive move");
	}

	public static void drawBoard(char board[][], int width, int height) {
		String line;
		for(int i = 0; i < height; i++) { //iterates each row
			line = sc.nextLine(); //get line
			for (int j = 0; j < width; j++) {
				board[i][j] = line.charAt(j); //fill 2d array line
			}
		}
	}

	public static void printBoard(char board[][], int width, int height) {
		System.out.println(width + " " + height);
		System.out.println(my_color);
		for(int i = 0; i < height; i++) { //iterates each row
			for (int j = 0; j < width; j++) {
				System.out.print(board[i][j]);
			}
			System.out.println("");
		}
	}

	public static void getBlanks(char board[][], int width, int height, ArrayList<Point> blanks) {
		for (int i = 0; i < height; i++) {
			for (int j = 0; j < width; j++) {
				if (board[i][j] == ' ') {
					blanks.add(new Point(i, j));
				}
			}
		}
	}

	public static void printAL(ArrayList<Point> list) {
		for(Point object : list)
			System.out.println(object.toString());
	}

	public static void findNeighbors(char board[][], ArrayList<Point> piece) {
		//iterates each blank, finds neighbors and if neighbor is opp piece it changes it to a '1' and ads point to valid_pieces
		neighbors.clear();

		for (Point blank_point : piece) {
			int i = (int) blank_point.getX();
			int j = (int) blank_point.getY();

			if(i > 0)
				neighbors.add(new Point(i - 1, j));
			if(i < max_i)
				neighbors.add(new Point(i + 1, j));
			if(j > 0)
				neighbors.add(new Point(i, j - 1));
			if(j < max_j)
				neighbors.add(new Point(i, j + 1));

		}
	}

	public static void validateNeighbors(char board[][], ArrayList<Point> neighbors) {
		for (Point neighbor_object : neighbors) {
			int row = (int) neighbor_object.getX();
			int col = (int) neighbor_object.getY();

			if(board[row][col] == opp_color.charAt(0)) {
				valid_pieces.add(new Point(row, col));
				board[row][col] = '1';
			}
		}

		neighbors.clear();
	}

	public static void findAllPieces(char board[][], ArrayList<Point> valid_pieces) {
		do {
			cont = 0;
			findNeighbors(board, valid_pieces);
			for (Point neighbor_object : neighbors) {
				int row = (int) neighbor_object.getX();
				int col = (int) neighbor_object.getY();

				if(board[row][col] == opp_color.charAt(0)) {
					valid_pieces.add(new Point(row, col));
					board[row][col] = '1';
					cont++;
				}
			}

		}while(cont > 0);
	}

}