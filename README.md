This is a wrapper around the [eSpeak NG](https://github.com/espeak-ng/espeak-ng) DLL for Windows. It aims to make it easier for an application using the .NET framework to provide built-in text synthesis using the eSpeak NG text-to-speech software.

## Usage

1. Download and install the 64-bit eSpeak NG installer from the eSpeak NG [latest release page]().
2. Paste the eSpeak DLL where the binary of your application is going to be. For example, if your binary is going to be built in `your-project\bin\64\debug\`, copy the eSpeak DLL there. You can find the eSpeak DLL at `C:\program files\espeak NG\libespeak-ng.dll`.
3. Download this project, and build it with Visual Studio.
4. In your own project, add a reference to the DLL file that you just built.
5. In your project, call the `ESpeakWrapper.Client.Initialize()`, and pass it the correct path to the `espeak-ng-data` directory. Normally, this is in the same directory ou copied the DLL from, namely `C:\program files\espeak NG`.
6. Now you're ready to roll! You can call other functions as you need.

## Contributions

Contribution is as easy as opening an issue, explaining the feature or bug you're trying to work on, getting a go-ahead, implementing it and submitting a pull request.

So, go ahead! :-)

[latest release page]: https://github.com/espeak-ng/espeak-ng/releases/latest