### No.52 longestWord
Define a word as a sequence of consecutive English letters. Find the longest word from the given string.

Example

For text = "Ready, steady, go!", the output should be
longestWord(text) = "steady".

Input/Output

    [execution time limit] 4 seconds (py3)

    [input] string text

    Guaranteed constraints:
    4 ≤ text.length ≤ 50.

    [output] string
        The longest word from text. It's guaranteed that there is a unique output.
#### python
```python
def longestWord(text):

    lista = list(text)
    long = len(lista)

    larger = 0
    #Current Size of word
    currentSize = 0
    #Store current word
    word = []
    #Store max size word
    wordMax = []

    for i in range(long):
        if lista[i].isalpha():
            currentSize += 1
            word.append(lista[i])
        else:
            if currentSize > larger:
                larger = currentSize
                wordMax = list(word)

            currentSize = 0
            word = []
    #We get to the end
    if currentSize > larger:
        larger = currentSize
        wordMax = list(word)
        word = []
    return ''.join(wordMax)
```
```python
def longestWord(text):
    return max(re.split('[^a-zA-Z]', text), key=len)
```