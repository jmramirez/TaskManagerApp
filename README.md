# TaskManagerApp 📝

A clean and maintainable **Task Manager** web API built with:

- ✅ .NET 9 (Minimal APIs)
- 🧱 Vertical Slice Architecture
- 🧠 Domain-Driven Design (DDD)
- 🗃️ PostgreSQL & EF Core
- 🧪 FluentValidation
- 🧩 Result Pattern for explicit error handling

---

## ✨ Features

- Add new tasks with validation
- Organize code by vertical slices (features)
- Strong domain model using Value Objects and Entities
- PostgreSQL integration with EF Core
- Easily extendable with new features like updates, deletes, due dates, priorities, and reminders

---

## 🗂 Project Structure
```bash
TaskManagerApp/
├── Api/ # Minimal API + Endpoints
├── Application/ # Use cases, commands, validators
├── Contracts/ # DTOs for API communication
├── Domain/ # Domain model (entities, value objects, rules)
├── Infrastructure/ # EF Core DbContext, DB configs
├── TaskManagerApp.sln
```

---

## ⚙️ Tech Stack

| Layer          | Tools / Libraries                        |
|----------------|-------------------------------------------|
| API            | .NET 9, Minimal APIs                     |
| Domain         | DDD, Value Objects, Result Pattern       |
| Application    | CQRS, FluentValidation                   |
| Persistence    | EF Core, PostgreSQL                      |
| Architecture   | Vertical Slice Architecture              |

---

## 🧠 Architecture Style

This project follows:

- **Vertical Slice Architecture** – each use case (CreateTask, etc.) is isolated
- **Domain-Driven Design – domain** logic is in the Domain layer
- **Minimal APIs** – clean and fast endpoints
- **Explicit Result** Handling – no silent failures
