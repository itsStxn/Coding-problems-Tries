# Tries

## Difficulties

### Medium
- Implement Trie Prefix Tree   	
- Design Add And Search Words Data Structure

## Patterns
- Prefix-based **tree-like structure**
- Works with **strings or characters**
- Each node represents **a character**
- Paths from root represent **words or prefixes**
- Uses **children map or fixed-size array**
- Uses **end-of-word marker**
- Asked to check **prefix existence**
- Asked to check **full word existence**
- Asked to **insert words**
- Asked to **search words**
- Asked to find **all words with a prefix**
- Asked to perform **autocomplete**
- Asked to count **prefix or word occurrences**
- Asked to **replace words using dictionary**
- Asked to **detect invalid prefixes**
- Asked to find **longest prefix**
- Asked to find **shortest unique prefix**
- Asked to search with **wildcards**
- DFS used to **explore trie paths**
- BFS sometimes used for **level-based logic**
- Time complexity depends on **word length**
- Space-time tradeoff for **fast lookups**
- Often combined with **backtracking**
- Root node usually **empty**
- Fixed alphabet size implies **constant branching**
- Good alternative to **hash sets for prefixes**
- Edge cases with **empty string**
- Edge cases with **shared prefixes**
- Requires careful handling of **end markers**
- Often used in **word search grids**
- Avoids repeated **string comparisons**
- Recursive traversal for **enumeration**
