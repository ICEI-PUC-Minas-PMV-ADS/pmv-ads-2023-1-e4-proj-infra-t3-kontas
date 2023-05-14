import React, { useState } from "react";
import "../styles/Cadastro.css";

function Cadastro() {
  const [email, setEmail] = useState("");
  const [name, setName] = useState("");
  const [password, setPassword] = useState("");
  const [code, setCode] = useState("");
  const [codeSent, setCodeSent] = useState(false);

  const handleEmailChange = (event) => {
    setEmail(event.target.value);
  };

  const handleNameChange = (event) => {
    setName(event.target.value);
  };

  const handlePasswordChange = (event) => {
    setPassword(event.target.value);
  };

  const handleCodeChange = (event) => {
    setCode(event.target.value);
  };

  const handleSendCode = () => {
    // lógica para enviar o código para o email do usuário
    setCodeSent(true);
  };

  const handleRegister = () => {
    // lógica para registrar o usuário com o código fornecido
    console.log(`Registrando usuário com email ${email} e código ${code}`);
  };

  return (
    <div className="register-box">
      <h2>Cadastro</h2>
      {!codeSent ? (
        <>
          <div className="user-box">
            <input
              type="nome"
              value={name}
              onChange={handleNameChange}
              required
            />
            <label>Nome</label>
          </div>
          <div className="user-box">
            <input
              type="senha"
              value={password}
              onChange={handlePasswordChange}
              required
            />
            <label>Senha</label>
          </div>
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

export default Cadastro;
