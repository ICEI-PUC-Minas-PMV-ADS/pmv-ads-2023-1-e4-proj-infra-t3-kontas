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
public class ContaRequest {
    private String descricao;
    private LocalDate vencimento;
    private BigDecimal valor;
    private Boolean pagar;
}
