import React, { useState } from "react";
import "../styles/Login.css";
import { Link, useNavigate } from "react-router-dom";

function Login() {
  const navigate = useNavigate();
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const handleUsernameChange = (event) => {
    setUsername(event.target.value);
  };

  const handlePasswordChange = (event) => {
    setPassword(event.target.value);
  };

  const onClick = () => {
    if (username && password === "admin") {
      return navigate("/");
    }

    return alert("Usuário ou senha inválidos");
  };

  return (
    <div className="login-box">
      <form>
        <div className="user-box">
          <input
            type="text"
            name=""
            required=""
            value={username}
            onChange={handleUsernameChange}
          />
          <label>Login</label>
        </div>
        <div className="user-box">
          <input
            type="password"
            name=""
            required=""
            value={password}
            onChange={handlePasswordChange}
          />
          <label>Senha</label>
        </div>
        <div>
          <button onClick={onClick}>Entrar</button>
        </div>
        <div>
          <Link to="/recuperarSenha">Esqueci minha senha</Link>
        </div>
        <div>
          <Link to="/cadastro">Cadastrar</Link>
        </div>
      </form>
    </div>
  );
}

export default Login;
