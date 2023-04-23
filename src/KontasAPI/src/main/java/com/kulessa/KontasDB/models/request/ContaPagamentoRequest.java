package com.kulessa.KontasDB.models.request;

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
public class ContaPagamentoRequest {
    private LocalDate data;
    private BigDecimal valor;
    private Integer contaId;
}
