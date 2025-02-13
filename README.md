[\[English\]](#CardFlagIdentifier) [\[Português\]](assets/READMEP.md)
_______________________________________________________________________________________________________________________________________
# CardFlagIdentifier
# Web API - Identifies Credit Card Flag

This project is a Web API developed in .NET that receives a credit card number and returns the corresponding flag.

## Technologies Used

- .NET 9
- ASP.NET Core Web API
- Swagger for documentation

## How to Run the Project

### Prerequisites

Make sure you have installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

### Clone the Repository

```sh
git clone https://github.com/G10van1/CardFlagIdentifier
cd CardFlagIdentifier
```

### Restore Dependencies

```sh
dotnet restore
```

### Run the API

```sh
dotnet run
```

The API will be available at `https://localhost:44343`

## Available Endpoints

### Check Flag Card

**Endpoint:** `GET /cardflag/{card number}`

**Request Body:**

```json
{
"cardnumber": "4111111111111111"
}
```

**Response:**

```json
{
"flag": "Visa"
}
```
## Recognized Cards

![Cards](./assets/flags.jpg)

## Contribution

1. Fork the repository.

2. Create a branch with your feature: `git checkout -b my-feature`
3. Commit your changes: `git commit -m 'Adds new feature'`
4. Push to the main branch: `git push origin my-feature`
5. Open a Pull Request.

## License

This project is under the MIT license.

