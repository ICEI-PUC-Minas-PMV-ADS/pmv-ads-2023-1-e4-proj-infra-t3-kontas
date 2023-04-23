package com.kulessa.KontasDB.entity;

import javax.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.util.Date;


@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
@Entity
@Table(name = "Conta")
public class Conta {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @Column(name = "Descricao")
    private String descricao;

    @Column(name = "Vencimento")
    private LocalDate vencimento;

    @Column(name = "Valor")
    private BigDecimal valor;

    @Column(name = "UserId")
    private String userId;

    @OneToOne(mappedBy = "conta", cascade = CascadeType.REMOVE, fetch = FetchType.LAZY)
    private ContaPagamento contaPagamento;

    @Column(name = "APagar")
    private Boolean pagar;
}
