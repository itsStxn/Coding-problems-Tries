using System;

namespace Design_Add_and_Search_Words_Data_Structure;

public class WordDictionary {
	public readonly WordDictionary?[] Children = new WordDictionary?[26];
	public bool IsEnd = false;
	
	public void AddWord(string word) {
		var curr = this;
		
		foreach (var ch in word) {
			int alpha = ch - 'a';
			var next = curr.Children[alpha] ?? new();
			curr.Children[alpha] = next;
			curr = next;
		}

		curr.IsEnd = true;
	}
	
	public bool Search(string word) {
		bool dfs(WordDictionary curr, int i = 0) {
			if (i == word.Length)
				return curr.IsEnd;
			
			var ch = word[i];
			if (ch == '.') {
				foreach (var sibling in curr.Children) {
					if (sibling != null && dfs(sibling, i + 1))
							return true;
				}
				return false;
			}

			var next = curr.Children[ch - 'a']; 
			if (next == null) return false;

			return dfs(next, i + 1);
		}

		return dfs(this);
	}
}
