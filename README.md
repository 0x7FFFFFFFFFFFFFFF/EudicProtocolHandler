# Eudic URL Handler for Windows

## Overview

This project provides a custom URL handler for Eudic Dictionary on Windows, enhancing the user experience for both Eudic and Anki users. It allows direct access to dictionary entries from clickable links, a feature previously available but removed due to antivirus concerns.

## Background

As an avid user of both Eudic Dictionary and Anki, I found that a convenient feature available on Android was missing on Windows. On Android, clicking certain links in Anki decks would directly open the corresponding entry in the Eudic Dictionary. This seamless integration significantly improves the efficiency of language learning and vocabulary review.

The Eudic developers explained that this feature was removed from the Windows version due to some antivirus software flagging the custom URL handler as potentially malicious. This project aims to restore this functionality for Windows users.

## Features

- Custom URL handler for Eudic Dictionary on Windows
- Enables direct access to dictionary entries from clickable links
- Seamless integration between Anki decks and Eudic Dictionary
- Improves efficiency in language learning and vocabulary review

## Installation

Just execute the executable file `EudicProtocolHandler.exe` and you are good to go.

## Usage

Use the custom URL handler in Anki flashcards by adding the following link format:

```html
<a href='eudic://dict//wit'>wit</a>
```

Then you can click the link to open the corresponding entry in Eudic Dictionary.

![](https://raw.githubusercontent.com/0x7FFFFFFFFFFFFFFF/EudicProtocolHandler/main/demo.gif)


## Compatibility

This URL handler is designed for use with:
- Windows operating system
- Eudic Dictionary (Windows version)
- Anki flashcard application (Windows version)

## Security Note

While this URL handler restores useful functionality, please be aware that some antivirus software may flag it as potentially suspicious due to its nature as a custom URL handler. We assure you that this software is safe to use, but encourage users to review the code and make informed decisions about its use on their systems.

## Contributing

Contributions to improve this URL handler are welcome. Please feel free to submit issues or pull requests.

## License

MIT License

## Disclaimer

This is an unofficial tool and is not affiliated with or endorsed by Eudic or Anki. Use at your own discretion.


