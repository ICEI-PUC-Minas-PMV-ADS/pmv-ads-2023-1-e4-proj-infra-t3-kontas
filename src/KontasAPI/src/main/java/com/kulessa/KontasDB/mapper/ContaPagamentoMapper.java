package com.kulessa.KontasDB.mapper;

import com.kulessa.KontasDB.dto.ContaPagamentoDTO;
import com.kulessa.KontasDB.entity.Conta;
import com.kulessa.KontasDB.entity.ContaPagamento;
import com.kulessa.KontasDB.models.request.ContaPagamentoRequest;
import org.springframework.stereotype.Component;

@Component
public class ContaPagamentoMapper {
    public static ContaPagamento toContaPagamento(ContaPagamentoRequest request, Conta conta) {
        return ContaPagamento.builder()
                .data(request.getData())
                .valor(request.getValor())
                .conta(conta)
                .build();
    }

    public static ContaPagamentoDTO toContaPagamentoDTO(ContaPagamento contaPagamento) {
        return ContaPagamentoDTO.builder()
                .id(contaPagamento.getId())
                .data(contaPagamento.getData())
                .valor(contaPagamento.getValor())
                .userId(contaPagamento.getConta().getUserId())
                .contaId(contaPagamento.getConta().getId())
                .build();
    }
}
