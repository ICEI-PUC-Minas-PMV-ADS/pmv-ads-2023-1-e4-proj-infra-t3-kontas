import React, { useState } from "react";
import "../styles/Cadastro.css";

function RecuperarSenha() {
  const [email, setEmail] = useState("");
  const [code, setCode] = useState("");
  const [codeSent, setCodeSent] = useState(false);

  const handleEmailChange = (event) => {
    setEmail(event.target.value);
  };

  const handleCodeChange = (event) => {
    setCode(event.target.value);
  };

  const handleSendCode = () => {
    // Aqui você pode adicionar a lógica para enviar o código para o email do usuário
    setCodeSent(true);
  };

  const handleRegister = () => {
    // Aqui você pode adicionar a lógica para registrar o usuário com o código fornecido
    console.log(`Registrando usuário com email ${email} e código ${code}`);
  };

  return (
    <div className="register-box">
      <h2>Recuperar Senha</h2>
      {!codeSent ? (
        <>
          <div className="user-box">
            <input
              type="email"
              value={email}
              onChange={handleEmailChange}
              required
            />
            <label>Email</label>
          </div>
          <div>
            <button onClick={handleSendCode}>Enviar código</button>
          </div>
        </>
      ) : (
        <>
          <div className="user-box">
            <input
              type="text"
              value={code}
              onChange={handleCodeChange}
              required
            />
            <label>Código</label>
          </div>
          <button onClick={handleRegister}>Registrar</button>
        </>
      )}
    </div>
  );
}

export default RecuperarSenha;
