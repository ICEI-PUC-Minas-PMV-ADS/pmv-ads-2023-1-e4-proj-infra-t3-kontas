import React, { useState } from "react";
import "../styles/HomeKontas.css";

function Atualizar() {
  const [contas, setContas] = useState([
    { id: 1, descricao: "Conta de Luz", status: "Pendente" },
    { id: 2, descricao: "Conta de Água", status: "Pendente" },
    { id: 3, descricao: "Conta de Internet", status: "Pendente" },
  ]);

  const handleStatusChange = (id, newStatus) => {
    const updatedContas = contas.map((conta) => {
      if (conta.id === id) {
        return { ...conta, status: newStatus };
      }
      return conta;
    });

    setContas(updatedContas);
  };

  return (
    <div className="home-box">
      <h1>Contas</h1>
      {contas.map((conta) => (
        <div key={conta.id}>
          <h3>{conta.descricao}</h3>
          <p>Status: {conta.status}</p>
          <button onClick={() => handleStatusChange(conta.id, "Pago")}>
            Marcar como Pago
          </button>
          <button onClick={() => handleStatusChange(conta.id, "Pendente")}>
            Marcar como Pendente
          </button>
        </div>
      ))}
    </div>
  );
}

export default Atualizar;
