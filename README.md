# Image to Icon Converter

This C# application provides a simple way to convert various image formats into icon files (.ico). It's particularly useful for developers needing custom icons for applications, websites, and more.

## Features

- Supports a variety of image formats, including PNG, JPEG, and BMP.
- Converts images to the .ico format.
- Allows for multiple icon sizes in a single .ico file.
- User-friendly command-line interface.

## Requirements

- .NET Framework (or .NET Core/5/6+ if applicable)
- Visual Studio or any C# IDE for development and compilation

## Installation

To set up and run the project, follow these steps:

1. **Clone the repository:**
   ```sh
   git clone [https://github.com/omar11batra/Images-To-Icons-Convert.git]
   ```


 2. Open the project:
    
 Open the .sln file in Visual Studio or your preferred C# IDE.

4. Build the project:
   
Build the solution to restore dependencies and compile the application.

## Usage
After building the project, you can run the executable from the command line to convert images to icons.

Command-Line Arguments
input_image: Path to the input image file.
output_icon: Path where the output .ico file should be saved.
sizes: (Optional) A comma-separated list of sizes for the icon (e.g., 16,32,48,64,128). If not specified, default sizes will be used.

## Example :

```sh
   ImageToIconConverter.exe input_image.png output_icon.ico 16,32,48
   ```

نسخ الكود
ImageToIconConverter.exe input_image.png output_icon.ico 16,32,48
This command converts input_image.png into an icon file output_icon.ico with sizes 16x16, 32x32, and 48x48 pixels.

## Batch Processing

```sh
   ImageToIconConverter.exe input_directory output_directory sizes
   ```

## Contact

For any questions or feedback, please contact aburad211@gmail.com.

```sh
   
Replace the placeholders like `https://github.com/omar11batra/Images-To-Icons-Convert.git`, `omar11batra`, and `aburad211@gmail.com` with your actual GitHub username and contact information. Make sure to customize any additional details specific to your project.
   ```


