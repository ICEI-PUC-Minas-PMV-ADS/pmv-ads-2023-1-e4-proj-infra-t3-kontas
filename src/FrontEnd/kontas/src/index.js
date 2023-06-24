import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import reportWebVitals from "./reportWebVitals";
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Login from "./view/Login";
import Cadastro from "./view/Cadastro";
import RecuperarSenha from "./view/RecuperarSenha";
import HomeKontas from "./view/HomeKontas";
import Atualizar from "./view/Atualizar";

const router = createBrowserRouter([
  {
    path: "/Login",
    element: <Login />,
  },
  {
    path: "cadastro",
    element: <Cadastro />,
  },
  {
    path: "recuperarSenha",
    element: <RecuperarSenha />,
  },
  {
    path: "/",
    element: <HomeKontas />,
  },
  {
    path: "atualizar",
    element: <Atualizar />,
  },
]);

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
