// Reddit user/Author: mattryan

import com.google.common.collect.BiMap;
import com.google.common.collect.HashBiMap;

public class MorseTranslator {
  private BiMap<String, Character> morseToLetterMap;
  private BiMap<Character, String> letterToMorseMap;

  public MorseTranslator() {
    morseToLetterMap = HashBiMap.create();
    morseToLetterMap.put(".-", 'a');
    morseToLetterMap.put("-...", 'b');
    morseToLetterMap.put("-.-.", 'c');
    morseToLetterMap.put("-..", 'd');
    morseToLetterMap.put(".", 'e');
    morseToLetterMap.put("..-.", 'f');
    morseToLetterMap.put("--.", 'g');
    morseToLetterMap.put("....", 'h');
    morseToLetterMap.put("..", 'i');
    morseToLetterMap.put(".---", 'j');
    morseToLetterMap.put("-.-", 'k');
    morseToLetterMap.put(".-..", 'l');
    morseToLetterMap.put("--", 'm');
    morseToLetterMap.put("-.", 'n');
    morseToLetterMap.put("---", 'o');
    morseToLetterMap.put(".--.", 'p');
    morseToLetterMap.put("--.-", 'q');
    morseToLetterMap.put(".-.", 'r');
    morseToLetterMap.put("...", 's');
    morseToLetterMap.put("-", 't');
    morseToLetterMap.put("..-", 'u');
    morseToLetterMap.put("...-", 'v');
    morseToLetterMap.put(".--", 'w');
    morseToLetterMap.put("-..-", 'x');
    morseToLetterMap.put("-.--", 'y');
    morseToLetterMap.put("--..", 'z');

    letterToMorseMap = morseToLetterMap.inverse();
  }

  public String translate(String sentence) {
    boolean isMorseToLetter = !Character.isLetter(sentence.charAt(0));

    StringBuilder translationBuilder = new StringBuilder();

    if (isMorseToLetter) {
      String[] words = sentence.split(" / ");
      for (String word : words) {
        String[] letters = word.split(" ");
        translationBuilder.append(translationBuilder.length() != 0 ? ' ' : "");
        for (String letter : letters) {
          translationBuilder.append(morseToLetterMap.get(letter));
        }
      }
    } else {
      String[] words = sentence.split(" ");
      for (String word : words) {
        translationBuilder
            .append(translationBuilder.length() != 0 ? " / " : "");
        StringBuilder translationWordBuilder = new StringBuilder();
        for (Character letter : word.toCharArray()) {
          translationWordBuilder
              .append(translationWordBuilder.length() != 0 ? ' ' : "");
          translationWordBuilder.append(letterToMorseMap.get(letter));
        }
        translationBuilder.append(translationWordBuilder);
      }
    }

    return translationBuilder.toString();
  }

  public static void main(String[] args) {
    String sentence = args[0];
    MorseTranslator translator = new MorseTranslator();
    System.out.println(translator.translate(sentence));
  }
}