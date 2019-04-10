using System;
using System.Text;

class cipher {
  public static void Main(string[] args) {
    string message = Console.ReadLine();
    int key = Convert.ToInt32(Console.ReadLine());

    StringBuilder sb = new StringBuilder("", message.Length);

    for (int i = 0; i < message.Length; i++) {
      char encryptedLetter;
      int val;

      if (Char.IsLetter(message[i])) {
        if (Char.IsUpper(message[i])) {
          val = (int) message[i] - 65;
          int newVal = val + key;
          int mod = newVal % 26;
          if (mod > 26) {
            mod -= 26;
          }
          encryptedLetter = (char) (mod + 65);
        } else {
          val = (int) message[i] - 97;
          int newVal = val + key;
          int mod = newVal % 26;
          if (mod > 26) {
            mod -= 26;
          }
          encryptedLetter = (char) (mod + 97);
        }
      } else if (Char.IsDigit(message[i])) {
        int newVal = (int) message[i] - 48 + key;
        int mod = newVal % 10;
        if (mod > 9) {
          mod -= 9;
        }
        encryptedLetter = (char) (mod + 48);
      } else {
        encryptedLetter = message[i];
      }

      sb.Append(encryptedLetter);
    }

    Console.WriteLine(sb.ToString());

  }
}
