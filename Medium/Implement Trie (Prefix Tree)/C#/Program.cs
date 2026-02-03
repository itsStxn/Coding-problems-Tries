using Implement_Trie_Prefix_Tree;

var trie = new Trie();
trie.Insert("apple");
Console.WriteLine(trie.Search("apple"));		// return True
Console.WriteLine(trie.Search("app"));			// return False
Console.WriteLine(trie.StartsWith("app"));	// return True
trie.Insert("app");
Console.WriteLine(trie.Search("app"));			// return True
