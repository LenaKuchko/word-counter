| Behavior | Input | Output |
|Convert sentence to List of words| Rose rose to put rose roes on her rows of roses| List<string> words|
|App returns number of repetitive words| Rose rose to put rose roes on her rows of roses. rose| The sentence contains word "rose" 3 times.|
|User enter a word which is not contained in sentence | Rose rose to put rose roes on her rows of roses. tulip| Word "tulip" is contained in the sentence 0 times. Please enter one of the words which are contained in the sentence.|
|Odd user's input like all capitalization, partial capitalization, etc.| RoSe rOse to put ROSE roes on her rows of roses. RosE | The sentence contains word "rose" 3 times.|
|User didn't enter the sentence | ______. rose| Please enter a sentence|
|User didn't enter the word | Rose rose to put rose roes on her rows of roses. _____ | Please enter a word, which you want to count |
