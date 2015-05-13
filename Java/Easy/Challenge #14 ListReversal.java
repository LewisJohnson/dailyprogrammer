// Reddit user/Author: mazzer
public static void main(String[] args) {
    StringBuilder result = new StringBuilder();
    final int blockSize = 3;
    String[] input = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};

    for (int currentIndex = 0; currentIndex < input.length; currentIndex += blockSize) {
        List<String> numberBlock = Arrays.asList(Arrays.copyOfRange(input, currentIndex, Math.min(currentIndex + blockSize, input.length)));
        Collections.reverse(numberBlock);
        result.append(numberBlock.toString().replaceAll("[\\[\\]]", "")).append(", ");
    }

    System.out.println(result.toString().substring(0, result.length() - 2));
}