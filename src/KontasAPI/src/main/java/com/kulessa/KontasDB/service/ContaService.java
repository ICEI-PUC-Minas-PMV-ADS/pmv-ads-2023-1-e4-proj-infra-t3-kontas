package com.kulessa.KontasDB.service;

import com.kulessa.KontasDB.entity.Conta;
import com.kulessa.KontasDB.mapper.ContaMapper;
import com.kulessa.KontasDB.models.request.ContaRequest;
import com.kulessa.KontasDB.repository.ContaRepository;
import javax.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
@Slf4j
public class ContaService {
    private final ContaRepository repository;

    @Transactional
    public Conta create(ContaRequest request, String userId) {
        return repository.save(ContaMapper.toConta(request, userId));
    }

    @Transactional
    public void delete(Integer id, String userId) {
        repository.deleteByIdAndUserId(id, userId);
    }

    @Transactional
    public Conta update(Conta conta, ContaRequest request) {
        conta.setDescricao(request.getDescricao());
        conta.setPagar(request.getPagar());
        conta.setValor(request.getValor());
        conta.setVencimento(request.getVencimento());

        return conta;
    }

    public Conta getById(Integer id, String userId) {
        return repository.findByIdAndUserId(id, userId).orElseThrow();
    }

    public List<Conta> getAll(String userId) {
        return repository.findByUserId(userId);
    }
}
