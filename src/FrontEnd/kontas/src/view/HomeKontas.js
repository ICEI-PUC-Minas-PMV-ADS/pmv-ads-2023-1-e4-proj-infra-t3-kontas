import React from "react";
import "../styles/HomeKontas.css";
import ListaContas from "./ListaContas";
import { useNavigate } from "react-router-dom";

function Cadastro() {
  const navigate = useNavigate();

  const onClick = () => {
    return navigate("/atualizar");
  };

  return (
    <div className="home-box">
      <h1>Patrícia Knowles</h1>
      <div>
        <ListaContas />
      </div>
      <div>
        <button onClick={onClick}>Atualizar</button>
      </div>
    </div>
  );
}

export default Cadastro;
