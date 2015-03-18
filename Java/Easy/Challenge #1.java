public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		System.out.println("What is your name, age, and reddit username?");

		System.out.println("Enter your name: ");
		String name = input.nextLine();

		System.out.println("Enter your age: ");
		String age = input.nextLine();

		System.out.println("Enter your reddit username: ");
		String redditUsername = input.nextLine();

		String output = "Your name is " + name + ", your age is " + age
				+ " years old, " + "and your reddit username is "
				+ redditUsername;
		System.out.println(output);

		input.close();

		File file = new File("dailyprogrammerchallenge1.txt");

		try {
			BufferedWriter bf = new BufferedWriter(new FileWriter(file));
			bf.write(output);
			bf.close();
		} 
		
		catch (IOException e) {
			e.printStackTrace();
		}

	}