package com.kulessa.KontasDB.entity;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.util.Date;

import javax.persistence.*;

import com.fasterxml.jackson.annotation.JsonBackReference;
import lombok.*;

@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
@Entity
@Table(name = "ContaPagamento")
public class ContaPagamento {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @OneToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "ContaId", referencedColumnName = "id")
    @JsonBackReference
    private Conta conta;

    @Column(name = "Valor", precision = 18, scale = 2, nullable = false)
    private BigDecimal valor;

    @Column(name = "Data", nullable = false)
    private LocalDate data;
}