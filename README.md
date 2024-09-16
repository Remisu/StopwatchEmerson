
# Stopwatch - ConometroEmerson

## Project Overview

This project, **ConometroEmerson**, is a simple stopwatch application developed to explore and learn about tools in Visual Studio. The stopwatch provides basic functionality such as start, stop, and reset. It was created as a learning exercise to understand better how to work with Windows Forms and time management in C#.

## Features

- **Start**: Begin counting time with millisecond precision.
- **Stop**: Pause the stopwatch, maintaining the current elapsed time.
- **Reset**: Reset the stopwatch to zero and prepare for a new count.
- **Real-time Display**: Updates the display to show elapsed time in hours, minutes, seconds, and milliseconds.

## Key Files and Classes

- `FrmCronometro.cs`: The main form class where the stopwatch functionality is implemented. It handles user interactions and the timer updates.
- `Program.cs`: The entry point of the application responsible for launching the form.

## How It Works

The application uses the `Stopwatch` class from the .NET framework to measure elapsed time. User interactions such as starting, stopping, and resetting the stopwatch are handled by buttons on the form. A timer updates the label that displays the elapsed time every tick.

## How to Run

1. Clone the repository.
   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory and build the solution:
   ```bash
   cd ConometroEmerson
   dotnet build
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

## Project Structure

- **FrmCronometro.cs**: Contains the logic for starting, stopping, resetting, and displaying the stopwatch time.
- **Program.cs**: Initializes the application and runs the main form.

## Tags

- `Stopwatch`
- `C#`
- `Windows Forms`
- `Visual Studio`
- `Time Management`
- `Learning Project`
