using System;

namespace Implement_Trie_Prefix_Tree;

public class Trie {
	public readonly Trie?[] Children = new Trie?[26];
	public bool IsEnd = false;
	
	public void Insert(string word) {
		Trie curr = this;
		foreach (var ch in word) {
			int alpha = ch - 'a'; 
			
			Trie next = curr.Children[alpha] ?? new();
			curr.Children[alpha] = next;
			curr = next;
		}

		curr.IsEnd = true;
	}
	
	public bool Search(string word) {
		Trie curr = this;
		foreach (var ch in word) {
			Trie? next = curr.Children[ch - 'a'];
			if (next == null) return false;
			curr = next;
		}

		return curr.IsEnd;	
	}
	
	public bool StartsWith(string prefix) {
		Trie curr = this;
		foreach (var ch in prefix) {
			Trie? next = curr.Children[ch - 'a'];
			if (next == null) return false;
			curr = next;
		}

		return true;		
	}
}
