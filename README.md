# Pixel-based Macro Solution

Pixel-based Macro Solution is a C# application built with Windows Forms, designed for recording and playing macros with a pixel-search feature. This project utilizes the Newtonsoft.Json framework for the configuration system and the MouseKeyHook library for hooking and detecting mouse and keyboard inputs during macro recording. The software enables users to create new macros, import and export macro files, and manipulate existing macros by manually adding or deleting mouse/keyboard/pixel-search/delay functions.

## Features

- **Macro Recording and Playback**: Record your actions and play them back effortlessly.

- **Pixel Search**: The macro engine includes a pixel-search feature, allowing you to interact with elements based on their pixel color.

- **Configurable Delay**: Set delays between each action while recording to ensure precise playback timing.

- **Config System with Newtonsoft.Json**: Use the powerful Newtonsoft.Json framework for managing and storing configuration settings.

- **MouseKeyHook Integration**: Efficiently hook and detect mouse and keyboard inputs during macro recording.

- **Macro Structure**: The code is organized around the "Macro" class, which contains a list of "Action" classes. Different action types, such as `DelayAction`, `KeyboardAction`, `MouseAction`, and `PixelAction`, inherit from the base "Action" class. The execution of these actions is managed through the `MacroManager`.

## Getting Started

1. Clone the repository to your local machine.
   ```bash
   git clone https://github.com/your-username/Pixel-based-Macro-Solution.git
   ```
2. Open the project in your preferred C# development environment.
3. Build and run the application.

## Dependencies
- [Newtonsoft.Json](https://www.newtonsoft.com/json): A popular high-performance JSON framework for .NET.
- [MouseKeyHook](https://github.com/gmamaladze/globalmousekeyhook): Library for global mouse and keyboard hooks.

## Usage
1. Create a new macro or import an existing one.
2. Record your actions or manually add mouse, keyboard, pixel-search, or delay functions.
3. Save your macro for later use or share it with others.
4. Play the macro to automate the recorded actions.

## Contributing
Feel free to contribute to the development of Pixel-based Macro Solution by opening issues or submitting pull requests. Your feedback and contributions are highly appreciated.

## License
This project is licensed under the [MIT License](LICENSE). See the LICENSE file for details.


