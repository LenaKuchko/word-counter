# Address Book
## Created by Olena Kuchko

### Description
An app that allows user to create and store contact information such as contact's name, phone number and address. Also user can add groups to address book and link contacts to this groups. User also is able to clear whole address book or just delete particular contact.

### Installation
1. Download or clone the repository from https://github.com/LenaKuchko/address-book.git.
2. Using PowerShell (for Windows), navigate to the directory in which you downloaded project, then run dnx kestrel to run server.
3. In your Web-browser enter - localhost:5004.
4. If you want to work with program code install Mono (http://www.mono-project.com/download/) and Nancy framework (http://nancyfx.org/).
5. Using IDE of your choice to open code.

### Known Bugs
No strict rules for phone Number input.
If user created an empty contact he is not able to delete it.
| Behavior | Input | Output |
|Convert sentence to List of words| Rose rose to put rose roes on her rows of roses| List<string> words|
|App returns number of repetitive words (case insensitive)| Rose rose to put rose roes on her rows of roses. rose| 2 |
|User enter a word which is not contained in sentence | Rose rose to put rose roes on her rows of roses. tulip| 0 |
|Odd user's input like all capitalization, partial capitalization, etc.| RoSe rOse to put ROSE roes on her rows of roses. RosE | 3 |
|User didn't enter the sentence | ______. rose|0|
