//initial dummy code (not working) the hash function is wrong I guess:
```
public bool IsAlienSorted(string[] words, string order) {
Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();
for (int i = 0; i < order.Length; i++)
{
dict.Add(order[i], new List<string>());
}
​
List<string>[] orderedWords = new List<string>[100];
for(int j = 0;j<orderedWords.Length;j++){
orderedWords[j] = new List<string>();
}
for (int i = 0; i < words.Length; i++)
{
int index = HashFunc(words[i]);
orderedWords[index].Add(words[i]);
}
foreach(var word in words){
int sortedIndex = HashFunc(word);
char firstChar = word[0];
foreach(var w in orderedWords[sortedIndex]){
if(w[0] == firstChar){
dict[firstChar].Add(w);
}