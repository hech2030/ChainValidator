### 🚀 Chain Validator Project  

This project provides a ✨ **clean and elegant solution** ✨ for eliminating long chains of `if` statements by implementing the **Chain of Responsibility** pattern. 💡  

---

### ⚙️ **How It Works**  
1. **Register Your Validator** 📝  
   Configure your validator by specifying:  
   - The **parameter object** to validate.  
   - The **expected response** from the chain.  

👉 [Example in Program.cs](https://github.com/hech2030/ChainValidator/blob/60d80dbc3944839dd21042f344f7f606a46399ac/ChainValidatorSample/Program.cs#L13)  

In this example:  
- `AddUserRequest` is the parameter being validated.  
- `ValidatorResult<bool>` is the expected response.  

---

### 🚀 **Usage**  
Simply trigger the chain like this:  
👉 [Example in Program.cs](https://github.com/hech2030/ChainValidator/blob/60d80dbc3944839dd21042f344f7f606a46399ac/ChainValidatorSample/Program.cs#L27)  

---

### ✅ **Result Object**  
The result will include an `IsSuccess` field 🟢, indicating whether the validation passed successfully or not ❌.  

---

💡 **Simplify your code, improve readability, and enhance maintainability with Chain Validator!** ⚡
