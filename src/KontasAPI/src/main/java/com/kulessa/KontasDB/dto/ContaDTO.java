package com.kulessa.KontasDB.dto;

import com.kulessa.KontasDB.entity.ContaPagamento;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.math.BigDecimal;
import java.time.LocalDate;

@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class ContaDTO {
    private Integer id;

    private String descricao;

    private LocalDate vencimento;

    private BigDecimal valor;

    private String userId;

    private ContaPagamentoDTO contaPagamento;

    private Boolean pagar;
}
