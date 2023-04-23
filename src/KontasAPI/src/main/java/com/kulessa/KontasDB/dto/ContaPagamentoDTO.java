package com.kulessa.KontasDB.dto;

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.kulessa.KontasDB.entity.Conta;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.Column;
import javax.persistence.FetchType;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import java.math.BigDecimal;
import java.time.LocalDate;

@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class ContaPagamentoDTO {
    private Integer id;

    private BigDecimal valor;

    private LocalDate data;

    private Integer contaId;

    private String userId;
}
