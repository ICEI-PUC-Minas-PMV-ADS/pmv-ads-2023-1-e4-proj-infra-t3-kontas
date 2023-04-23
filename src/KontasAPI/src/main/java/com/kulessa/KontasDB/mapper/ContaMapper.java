package com.kulessa.KontasDB.mapper;

import com.kulessa.KontasDB.dto.ContaDTO;
import com.kulessa.KontasDB.entity.Conta;
import com.kulessa.KontasDB.models.request.ContaRequest;
import org.springframework.stereotype.Component;

@Component
public class ContaMapper {
    public static Conta toConta(ContaRequest request, String userId) {
        return Conta.builder()
                .descricao(request.getDescricao())
                .vencimento(request.getVencimento())
                .valor(request.getValor())
                .pagar(request.getPagar())
                .userId(userId)
                .build();
    }

    public static ContaDTO toContaDTO(Conta conta) {
        return ContaDTO.builder()
                .id(conta.getId())
                .vencimento(conta.getVencimento())
                .descricao(conta.getDescricao())
                .valor(conta.getValor())
                .pagar(conta.getPagar())
                .userId(conta.getUserId())
                .contaPagamento(conta.getContaPagamento() != null ? ContaPagamentoMapper.toContaPagamentoDTO(conta.getContaPagamento()) : null)
                .build();
    }
}
