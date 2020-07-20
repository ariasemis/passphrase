Small `.fsx` script that generates random passphrases.

Inspired by <https://www.eff.org/dice>

## Usage

1. Install .NET Core 3.0 or higher if you don't have it already
2. Restore dependencies
  ```
  dotnet tool restore
  dotnet paket restore
  ```
3. Run script
  ```
  dotnet fsi passphrase.fsx
  ```

## License

The wordlist included was created by Electronic Frontier Foundation, and is distributed under the Creative Commons Attribution 3.0.
The script itself is licensed under the MIT license.
