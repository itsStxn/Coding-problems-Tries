# Implement Trie (Prefix Tree)

## Description
A trie (pronounced as "try") or **prefix tree** is a tree data structure used to efficiently store and retrieve keys in a dataset of strings. There are various applications of this data structure, such as autocomplete and spellchecker.

Implement the Trie class:

- `Trie()` Initializes the trie object.
- `void insert(String word)` Inserts the string word into the trie.
- `boolean search(String word)` Returns `true` if the string word is in the trie (i.e., was inserted before), and `false` otherwise.
- `boolean startsWith(String prefix)` Returns `true` if there is a previously inserted string word that has the prefix prefix, and `false` otherwise.

### Example 1
**Input**  
["Trie", "insert", "search", "search", "startsWith", "insert", "search"]  
[[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]

**Output**  
[null, null, true, false, true, null, true]

**Explanation**:  
```code
Trie trie = new Trie();
trie.insert("apple");
trie.search("apple");   // return True
trie.search("app");     // return False
trie.startsWith("app"); // return True
trie.insert("app");
trie.search("app");     // return True
```

### Constraints
1 <= `word.length`, `prefix.length` <= 2000  
word and prefix consist only of lowercase English letters.  
At most **3 * 10^4** calls in total will be made to `insert`, `search`, and `startsWith`.

## Strategy
Each trie has an array of fixed 26 tries, which represent the children. It is 26 because of the alphabet.

For `insert`, `search` and `startWith` the base logic is the same: get a current trie `curr` and simply iterate for each character in a word and see if the character points to a non null trie inside the children array of `curr`. From there on, either keep inserting or checking something.

## Time Complexity - O(m)
With `m` being the length of the input word, the operation literally just involves the word's characters for all the `Trie` class' functions.

## Space Complexity - O(n)
Class wise, the space consumed depends on all the tries initiaded by non shared letters, which store fixed size arrays.
