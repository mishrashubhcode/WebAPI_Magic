# WebAPI Magic

WebAPI Magic is a powerful API that provides various endpoints for performing calculations and returning greetings. It is built using C# and ASP.NET Web API.

## Installation

1. Clone the repository to your local machine:

git clone https://github.com/mishrashubhcode/webapi-magic.git


2. Open the solution file (`WebAPIMagic.sln`) in Visual Studio or your preferred IDE.

3. Build the solution to restore NuGet packages and compile the code.

4. Run the project by pressing F5 or using the debugging options in your IDE.

## API Endpoints

### AddTenController

- **GET /api/addten/{id}**
- Adds ten to the specified number.
- Example: `/api/addten/5` returns `15`.

### SquareController

- **GET /api/square/{id}**
- Gets the square of the specified number.
- Example: `/api/square/3` returns `9`.

### GreetingController

- **GET /api/greeting**
- Returns the greeting "Hello World!".
- Example: `/api/greeting` returns `"Hello World!"`.

- **POST /api/greeting**
- Returns a greeting to the specified number of people.
- Example: `/api/greeting` with body `{"count": 3}` returns `"Hello to 3 people!"`.

### NumberMachineController

- **POST /api/numbermachine**
- Applies four mathematical operations to the input number in separate steps.
- Example: `/api/numbermachine` with body `{"number": 10}` returns `{"addResult": 20, "subtractResult": 5, "multiplyResult": 50, "divideResult": 2}`.

### HostingCostController

- **GET /api/hostingcost/{days}**
- Calculates the total hosting cost based on the number of days elapsed since the beginning of hosting.
- Example: `/api/hostingcost/7` returns `"Total hosting cost for 7 days is $38.22"`.

## Contributing

Contributions to this project are welcome. If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.


