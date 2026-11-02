# Code Review and Required Fixes for DalTest Program

## 1. Purpose of the file
The main program in DalTest is intended to test the DAL layer manually via a console UI. Its job is to:
- initialize the data layer,
- offer a main menu for entity selection,
- show a sub-menu for CRUD operations,
- call the appropriate DAL methods,
- display the result on screen,
- handle exceptions with try/catch.

The file should act as a thin console driver only, without business validation logic.

---

## 2. Required structure
The program must be built around a `Program` class and a static field called `s_dal`:

```csharp
public static class Program
{
    private static readonly IDal s_dal = new DalList();
}
```

This is required by the assignment.

---

## 3. Main program initialization requirement
At the start of `Main`, the code must call:

```csharp
Initialization.Initialize(s_dal);
```

This is required before running the menu.

---

## 4. Catching exceptions
The assignment requires wrapping the flow with `try/catch` and printing the exception message:

```csharp
try
{
    Initialization.Initialize(s_dal);
    MainMenu();
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

This pattern is required in the main entry point and for the private methods that may throw.

---

## 5. Required menu structure
The program should have:
- a main menu for choosing an entity
- a sub-menu for CRUD actions for that entity
- exit option (`0`)

Example shape:

```csharp
public static void MainMenu()
{
    int choice;
    do
    {
        choice = PrintMainMenu();
        switch (choice)
        {
            case 1:
                SubMenu("Answer");
                break;
            case 2:
                SubMenu("Question");
                break;
            case 0:
                Console.WriteLine("Exiting...");
                break;
        }
    } while (choice != 0);
}
```

---

## 6. Required DAL contract
The actual contract is defined by the interface files in the DalFacade project. The project uses these method names:

```csharp
public interface ICrud<T>
{
    int Create(T item);
    T? Read(int id);
    List<T> ReadAll();
    void Update(T item);
    void Delete(int id);
}
```

This is the authoritative contract to follow.

### Important mismatch in the current code
The current code uses names like:
- `Add`
- `GetById`
- `GetAll`

These names do not exist in the actual DAL contract. This is a major issue.

---

## 7. Required `QuestionForStudent` handling
For `QuestionForStudent`, the assignment requires special treatment because it is not a regular single-id entity. The contract is:

```csharp
QuestionForStudent? Read(int studentId, int testId, int questionId);
void Delete(int studentId, int testId, int questionId);
```

The UI must collect three ids and call those methods accordingly.

---

## 8. Required use of TryParse
The assignment explicitly states that numeric and date conversions must use `TryParse`:

```csharp
int id;
while (!int.TryParse(Console.ReadLine(), out id))
    Console.Write("Invalid ID. Try again: ");
```

The present code uses `Convert.ToInt32(...)` and `DateTime.Parse(...)`, which does not match the requirement.

---

## 9. Current code review findings
The current version of the program violates the assignment in several ways:

### A. Wrong program structure
The code is not enclosed in a proper `Program` class. It appears to be directly in a namespace.

### B. Wrong DAL method names
Methods such as `Add`, `GetById`, `GetAll` are incorrect according to the actual interface design.

### C. Missing correct initialization
`Initialization.Initialize(s_dal)` must be called in the main entry point and in the proper structure.

### D. Main menu logic is inconsistent
The menu prints choices and exits, but the actual branch logic and break flow are incorrect.

### E. Sub-menu logic is not aligned with the real API
Sub-menu actions should call `Create`, `Read`, `ReadAll`, `Update`, and `Delete` on the correct repository interface.

### F. QuestionForStudent is mishandled
The code does not correctly implement the composite key read/delete logic.

### G. Exceptions are not handled consistently
The try/catch requirement is only partly implemented, and the code still has broken flow that prevents the proper program model.

---

## 10. Recommended fix structure
The correct approach is:

1. Keep the overall program layout intact
   - `Main`
   - `MainMenu`
   - `PrintMainMenu`
   - `SubMenu`
   - `PrintSubMenu`
   - CRUD helper functions

2. Fix method calls to match the actual DAL API
   - `Create` instead of `Add`
   - `Read` instead of `GetById`
   - `ReadAll` instead of `GetAll`

3. Use `TryParse` for numeric/date input

4. Keep the code as a thin console UI only
   - no validation logic beyond parser loops
   - no business rules

5. Keep the menu behavior consistent with the assignment
   - top level chooses entity
   - sub-menu chooses CRUD action
   - exit with `0`

---

## 11. Final assessment
The program is not yet compliant with the assignment. It needs structural corrections and DAL API alignment before it can be considered a valid DalTest console testing application.

The biggest root cause is that the current code was written against an old or incorrect API assumption instead of the actual interfaces in the DAL layer.

---

## 12. Minimal accepted target behavior
A correct version of the program should:
- compile successfully,
- initialize the data layer,
- offer menu-driven CRUD testing for all entities,
- use the actual DAL methods,
- use `TryParse` for input,
- handle exceptions with `try/catch` and print the exception message.

This is the target the implementation should meet.
