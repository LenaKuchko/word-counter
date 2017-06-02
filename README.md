| Behavior | Input | Output |
|Convert sentence to List of words| Rose rose to put rose roes on her rows of roses| List<string> words|
|App returns number of repetitive words (case insensitive)| Rose rose to put rose roes on her rows of roses. rose| 2 |
|User enter a word which is not contained in sentence | Rose rose to put rose roes on her rows of roses. tulip| 0 |
|Odd user's input like all capitalization, partial capitalization, etc.| RoSe rOse to put ROSE roes on her rows of roses. RosE | 3 |
|User didn't enter the sentence | ______. rose|0|
