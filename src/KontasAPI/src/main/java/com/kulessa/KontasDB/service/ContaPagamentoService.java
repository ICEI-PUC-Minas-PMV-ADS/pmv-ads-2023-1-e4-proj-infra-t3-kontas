package com.kulessa.KontasDB.service;

import com.kulessa.KontasDB.entity.Conta;
import com.kulessa.KontasDB.entity.ContaPagamento;
import com.kulessa.KontasDB.mapper.ContaPagamentoMapper;
import com.kulessa.KontasDB.models.request.ContaPagamentoRequest;
import com.kulessa.KontasDB.models.request.UpdateContaPagamentoRequest;
import com.kulessa.KontasDB.repository.ContaPagamentoRepository;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;

@Service
@RequiredArgsConstructor
@Slf4j
public class ContaPagamentoService {
    private final ContaPagamentoRepository repository;
    private final ContaService contaService;

    @Transactional
    public ContaPagamento create(ContaPagamentoRequest request, String userId) {
        var conta = contaService.getById(request.getContaId(), userId);
        var contaPagamento = repository.save(ContaPagamentoMapper.toContaPagamento(request, conta));
        conta.setContaPagamento(contaPagamento);

        return contaPagamento;
    }

    @Transactional
    public ContaPagamento update(ContaPagamento contaPagamento, UpdateContaPagamentoRequest request) {
        contaPagamento.setValor(request.getValor());
        contaPagamento.setData(request.getData());

        return contaPagamento;
    }

    public ContaPagamento getById(Integer id, String userId) {
        return repository.findByIdAndContaUserId(id, userId).orElseThrow();
    }

    public void delete(Integer id, String userId) {
        repository.deleteByIdAndContaUserId(id, userId);
    }
}
