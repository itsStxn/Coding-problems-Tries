# Design Add and Search Words Data Structure

## Description
Design a data structure that supports adding new words and finding if a string matches any previously added string.

Implement the WordDictionary class:

- `WordDictionary()` Initializes the object.
- `void addWord(word)` Adds word to the data structure, it can be matched later.
- `bool search(word)` Returns `true` if there is any string in the data structure that matches word or `false` otherwise. word may contain dots '.' where dots can be matched with any letter.

### Example 1
**Input**  
["WordDictionary","addWord","addWord","addWord","search","search","search","search"]  
[[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]

**Output**
[null,null,null,null,false,true,true,true]

**Explanation**:  
```code
WordDictionary wordDictionary = new WordDictionary();  
wordDictionary.addWord("bad");  
wordDictionary.addWord("dad");  
wordDictionary.addWord("mad");  
wordDictionary.search("pad"); // return False  
wordDictionary.search("bad"); // return True  
wordDictionary.search(".ad"); // return True  
wordDictionary.search("b.."); // return True
```

### Constraints
1 <= `word.length` <= 25  
word in addWord consists of lowercase English letters.  
word in search consist of '.' or lowercase English letters.  
There will be at most 2 dots in word for search queries.  
At most 10^4 calls will be made to addWord and search.

## Strategy
Implement a trie with a recursive `dfs` tweak when it comes to `Search` function. The tweak will recursively iterate for each child of a current trie if the current character of a word is '., otherwise it keeps on indexing to certain tries thanks to the ASCII of the character.

## Time Complexity

### Insert - O(m)
With `m` being the length of an input word, the function only processes its characters.

### Search - O(26^k * m)
With `m` being the length of an input word and `k` the amount of '.', the function only processes the characters of the word when they are not dots, otherwise is checks validity for 26 alphabetical spots recursively.

## Space Complexity - O(n)
Class wise, all the characters are stored in fixed size arrays.
